package com.example.cajerosimulator
import android.annotation.SuppressLint
import android.content.Context
import android.os.Bundle
import android.widget.*
import androidx.appcompat.app.AppCompatActivity
import com.example.cajerosimulator.R.*


class MainActivity : AppCompatActivity() {

    private lateinit var tvSaldo: TextView
    private lateinit var etMonto: EditText
    private lateinit var btnConsignar: Button
    private lateinit var btnRetirar: Button
    private lateinit var tvHistorial: TextView

    private var saldo: Int = 0
    private val PREFS_NAME = "CajeroPrefs"
    private val SALDO_KEY = "saldo"
    private val HISTORIAL_KEY = "historial"

    @SuppressLint("MissingInflatedId")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(layout.activity_main)

        tvSaldo = findViewById(id.tvSaldo)
        etMonto = findViewById(id.etMonto)
        btnConsignar = findViewById(id.btnConsignar)
        btnRetirar = findViewById(id.btnRetirar)
        tvHistorial = findViewById(id.tvHistorial)

        cargarSaldo()
        mostrarHistorial()

        btnConsignar.setOnClickListener {
            val monto = etMonto.text.toString().toIntOrNull()
            if (monto != null && monto > 0) {
                saldo += monto
                actualizarSaldo()
                guardarEnHistorial("Consignación de $$monto")
            } else {
                mostrarMensaje("Ingrese un monto válido para consignar")
            }
        }

        btnRetirar.setOnClickListener {
            val monto = etMonto.text.toString().toIntOrNull()
            if (monto != null && monto > 0) {
                if (monto <= saldo) {
                    saldo -= monto
                    actualizarSaldo()
                    guardarEnHistorial("Retiro de $$monto")
                } else {
                    mostrarMensaje("Saldo insuficiente para realizar el retiro")
                }
            } else {
                mostrarMensaje("Ingrese un monto válido para retirar")
            }
        }
    }

    private fun cargarSaldo() {
        val prefs = getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE)
        saldo = prefs.getInt(SALDO_KEY, 0)
        actualizarVistaSaldo()
    }

    private fun actualizarSaldo() {
        val prefs = getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE)
        with(prefs.edit()) {
            putInt(SALDO_KEY, saldo)
            apply()
        }
        actualizarVistaSaldo()
        etMonto.text.clear()
    }

    private fun actualizarVistaSaldo() {
        tvSaldo.text = "Saldo actual: $$saldo"
    }

    private fun mostrarMensaje(mensaje: String) {
        Toast.makeText(this, mensaje, Toast.LENGTH_SHORT).show()
    }

    private fun guardarEnHistorial(transaccion: String) {
        val prefs = getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE)
        val historial = prefs.getStringSet(HISTORIAL_KEY, mutableSetOf())?.toMutableSet() ?: mutableSetOf()
        historial.add("${transaccion} - ${java.time.LocalDateTime.now()}")
        with(prefs.edit()) {
            putStringSet(HISTORIAL_KEY, historial)
            apply()
        }
        mostrarHistorial()
    }

    private fun mostrarHistorial() {
        val prefs = getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE)
        val historial = prefs.getStringSet(HISTORIAL_KEY, setOf())?.sorted() ?: listOf()
        tvHistorial.text = "Historial:\n" + historial.joinToString("\n")
    }
}
