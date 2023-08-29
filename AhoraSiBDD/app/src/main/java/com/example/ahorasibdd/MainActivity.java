package com.example.ahorasibdd;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

   public EditText nombre, apellido, nota1, nota2, nota3;
   public Button btnEnviar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        nombre = (EditText) findViewById(R.id.Nombre);
        apellido = (EditText) findViewById(R.id.Apellido);
        nota1 = (EditText) findViewById(R.id.nota1);
        nota2 = (EditText) findViewById(R.id.nota2);
        nota3 = (EditText) findViewById(R.id.nota3);
        btnEnviar = findViewById(R.id.button1);

        btnEnviar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Bundle enviaDatos = new Bundle();
                enviaDatos.putString("keyDatos",nombre.getText().toString());
                enviaDatos.putString("keyDatos2",apellido.getText().toString());
                enviaDatos.putString("keyDatos3",nota1.getText().toString());
                enviaDatos.putString("keyDatos4",nota2.getText().toString());
                enviaDatos.putString("keyDatos5",nota3.getText().toString());


                Intent intent = new Intent(MainActivity.this, MainActivity2.class);
                intent.putExtras(enviaDatos);
                startActivity(intent);


            }
        });

    }
}