package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Adapter;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

import java.lang.reflect.Array;

public class Banners<context> extends AppCompatActivity {
 private Spinner spiner1;
 private EditText et1,et2;
 private EditText etMultiLine;
 private String valor1_String;
 private String valor2_String;
 private Object EditText;
 private Object View;
 private Button calcula;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_banners);
     et1=(EditText)findViewById(R.id.txt_valor1);
     et2=(EditText)findViewById(R.id.txt_valor2);
     etMultiLine=(EditText)findViewById(R.id.etMultiLine);
     spiner1=(Spinner)findViewById(R.id.spinner);

        final String multiplica = "multiplica";
        String [] opciones =('Lona Mate');
        ArrayAdapter<String> adapter;
        adapter = new ArrayAdapter<String>
                (context.this.android.R.layout.simple_spinner_item, opciones);
        spiner1.setAdapter(adapter);


     public void calcula(View Object view);
     String valor1_int= String.valueOf(Integer.parseInt(valor1_String));
     String valor2_int= String.valueOf(Integer.parseInt(valor2_String));

     String seleccion =spiner1.getSelectedItem().toString();
     if(seleccion.equals(multiplica)) {
         int multiplica = valor1_int * valor2_int;
        String resultado=String.valueOf(multiplica);
        etMultiLine.setText(resultado);


    }
}
}