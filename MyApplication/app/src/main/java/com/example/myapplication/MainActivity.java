package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    private EditText txtname;
    private Intent PackageContext;
    private EditText txtapellido;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().hide();

     txtname=(EditText)findViewById(R.id.txtname);
     txtapellido=(EditText) findViewById(R.id.txtapellido);
    }
    public void Ingresar(View view){
        Intent it =new Intent(this,MainActivity2.class);
        startActivity(it);

    }

}