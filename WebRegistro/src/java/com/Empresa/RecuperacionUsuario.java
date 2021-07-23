/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.Empresa;

/**
 *
 * @author luisr
 */
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class RecuperacionUsuario
 */
@WebServlet("/RecuperacionUsuario")
public class RecuperacionUsuario extends HttpServlet {

    private static final long serialVersionUID = 1L;

    /**
     * @see HttpServlet#HttpServlet()
     */
    public RecuperacionUsuario() {
        super();
        // TODO Auto-generated constructor stub
    }

    /**
     * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
     * response)
     */
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        // TODO Auto-generated method stub
    }

    /**
     * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
     * response)
     */
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        int exito = 0;
        PrintWriter out = response.getWriter();

        out.println("<html>");
        out.println("<head></head>");
        out.println("<body>");

        out.println("Cedula:");
        String Cedula = request.getParameter("Cedula");
        out.println(Cedula);
        out.println("<br>");
        out.println("Nombre:");
        String Nombre = request.getParameter("Nombre");
        out.println(Nombre);
        out.println("<br>");
        out.println("Telefono:");
        String Telefono = request.getParameter("Telefono");
        out.println(Telefono);
        out.println("<br>");
        out.println("Correo:");
        String Correo = request.getParameter("Correo");
        out.println(Correo);

        Cliente c = new Cliente(Integer.parseInt(Cedula), Nombre, Integer.parseInt(Telefono), Correo);
        DB insert = new DB();
        insert.setConn();
        exito = insert.insertCliente(c);

        if (exito == 1) {
            out.println("<h3>Se registro el cliente con exito.</h3>");
        }
        if (exito == 0) {
            out.println("<h3>El cliente no se pudo registrar.</h3>");
        }

        out.println("</body>");
        out.println("</html>");

    }

}
