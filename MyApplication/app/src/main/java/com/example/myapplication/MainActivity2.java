package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity2 extends AppCompatActivity {

    private Button btnbanners;
    private Button btnbastidores;
    private Button btnadesivos;
    private Button btnseñaleticas;
    private Button btnimprenta;
    private Button btncajaluminosa;
    private Button btnproforma;
    private Button btnetiquetascorp;
    private Button btnsalir;
    private Intent PackageContext;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().hide();

        btnbanners=(Button)findViewById(R.id.btnbanners);
        btnbastidores=(Button)findViewById(R.id.btnbastidores);
        btnadesivos=(Button)findViewById(R.id.btnadesivos);
        btnseñaleticas=(Button)findViewById(R.id.btnseñaleticas);
        btnimprenta=(Button)findViewById(R.id.btnimprenta);
        btncajaluminosa=(Button)findViewById(R.id.btncajaluminosa);
        btnproforma=(Button)findViewById(R.id.btnproforma);
        btnetiquetascorp=(Button)findViewById(R.id.btnetiquetascorp);
        btnsalir=(Button)findViewById(R.id.btnsalir);
    }
        public void banners(View view){
            Intent it =new Intent(this,Banners.class);
            startActivity(it);


        }
          }


