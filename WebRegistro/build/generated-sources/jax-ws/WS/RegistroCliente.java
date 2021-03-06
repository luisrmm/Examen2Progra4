
package WS;

import java.util.List;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebService(name = "RegistroCliente", targetNamespace = "http://WS/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface RegistroCliente {


    /**
     * 
     * @param idCliente
     * @param string
     * @param telefono
     * @param nombre
     * @return
     *     returns java.util.List<java.lang.Object>
     */
    @WebMethod(operationName = "Registrar")
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "Registrar", targetNamespace = "http://WS/", className = "WS.Registrar")
    @ResponseWrapper(localName = "RegistrarResponse", targetNamespace = "http://WS/", className = "WS.RegistrarResponse")
    @Action(input = "http://WS/RegistroCliente/RegistrarRequest", output = "http://WS/RegistroCliente/RegistrarResponse")
    public List<Object> registrar(
        @WebParam(name = "IDCliente", targetNamespace = "")
        int idCliente,
        @WebParam(name = "Nombre", targetNamespace = "")
        String nombre,
        @WebParam(name = "Telefono", targetNamespace = "")
        String telefono,
        @WebParam(name = "String", targetNamespace = "")
        String string);

}
