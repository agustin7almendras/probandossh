package com.example.ahorasibdd;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity2 extends AppCompatActivity {

    public TextView nombres,apellido,nota1,nota2,nota3;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);

        nombres = findViewById(R.id.txtNombre);
        apellido = findViewById(R.id.txtApellido);
        nota1 = findViewById(R.id.txtnota1);
        nota2 = findViewById(R.id.txtnota2);
        nota3 = findViewById(R.id.txtnota3);


        Bundle recibeDatos = getIntent().getExtras();
        String info = recibeDatos.getString("keyDatos");
        nombres.setText("Nombre: "+info);

        String info2 = recibeDatos.getString("keyDatos2");
        apellido.setText("Apellido: "+info2);
        String info3 = recibeDatos.getString("keyDatos3");
        nota1.setText("Nota 1: "+info3);
        String info4 = recibeDatos.getString("keyDatos4");
        nota2.setText("Nota 2: "+info4);
        String info5 = recibeDatos.getString("keyDatos5");
        nota3.setText("Nota 3: "+info5);


    }
}