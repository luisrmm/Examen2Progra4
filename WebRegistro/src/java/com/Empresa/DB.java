/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.Empresa;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author luisr
 */
public class DB {

    public DB() {
        this.conn = null;
        this.port = "3306";
        this.username = "root";
        this.password = "admin";
        this.hostname = "localhost";
        this.database = "servicioinfor";
        this.driver = "com.mysql.jdbc.Driver";
        this.url = "jdbc:mysql://localhost:3306/servicioinfor?allowPublicKeyRetrieval=true&useSSL=false";
    }

    private Connection conn;

    private final String driver;

    // Nombre de la base de datos
    private final String database;

    // Host
    private final String hostname;

    // Puerto
    private final String port;

    // Ruta de nuestra base de datos (desactivamos el uso de SSL con "?useSSL=false")
    private final String url;

    // Nombre de usuario
    private final String username;

    // Clave de usuario
    private final String password;

    public Connection getConn() {
        return conn;
    }

    public void setConn() {
        try {
            Class.forName(driver);
            this.conn = DriverManager.getConnection(url, username, password);
        } catch (ClassNotFoundException | SQLException e) {
            System.out.println(e);
        }
    }

    public int insertCliente(Cliente cliente) {
        int exito = 0;
        try {
            String insertTableSQL = "INSERT INTO cliente"
                    + "(IDCliente, Nombre, Telefono, Correo) VALUES"
                    + "(?, ?, ?, ?)";

            PreparedStatement stmt = this.getConn().prepareStatement(insertTableSQL, Statement.RETURN_GENERATED_KEYS);
            stmt.setInt(1, cliente.getCedula());
            stmt.setString(2, cliente.getNombre());
            stmt.setInt(3, cliente.getTelefono());
            stmt.setString(4, cliente.getCorreo());
            if (stmt.executeUpdate() == 1) {
                exito = 1;
            }else{
                exito = 2;
            }
        } catch (SQLException ex) {
            Logger.getLogger(DB.class.getName()).log(Level.SEVERE, null, ex);
        }
        return exito;
    }

}
