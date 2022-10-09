public class Main
{
    public static void main(String[] args) {
        Cliente cliente = new Cliente();
        
        cliente.setEdad(33);
        cliente.setNombre("Kristian");
        cliente.setTelefono("+59389xxxxx2");
        cliente.setCredito(200);
        
        System.out.println("El cliente " +  cliente.getNombre() + 
        " tiene: " + cliente.getEdad() + " años de edad," +
        " su número telefono es: " + cliente.getTelefono() +
        " y posee un credito de: " + cliente.getCredito()
        );
        
        System.out.println("");
        
        Trabajador tabajador = new Trabajador();
        
        tabajador.setEdad(33);
        tabajador.setNombre("Kristian");
        tabajador.setTelefono("+59389xxxxx2");
        tabajador.setSalario(700);
        
        System.out.println("El trabajador " +  tabajador.getNombre() + 
        " tiene " + tabajador.getEdad() + " años de edad," +
        " su número telefono es: " + tabajador.getTelefono() +
        " y percibe un salario de: " + tabajador.getSalario()
        );
    }
}

class Persona
{
    private int edad;
    private String nombre;
    private String telefono;
    
    // Getter edad
    public int getEdad() {
        return edad;
    }
    
    // Setter edad
    public void setEdad(int edad) {
        this.edad = edad;
    }
    
    // Getter nombre
    public String getNombre() {
        return nombre;
    }
    
    // Setter nombre
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    
    // Getter telefono
    public String getTelefono() {
        return telefono;
    }
    
    // Setter telefono
    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }
}

class Cliente extends Persona
{
    private int credito;
    
    // Getter credito
    public int getCredito() {
        return credito;
    }
    
    // Setter credito
    public void setCredito(int credito) {
        this.credito = credito;
    }
}


class Trabajador extends Persona
{
    private int salario ;
    
    // Getter salario 
    public int getSalario () {
        return salario ;
    }
    
    // Setter salario 
    public void setSalario(int salario) {
        this.salario  = salario ;
    }
}