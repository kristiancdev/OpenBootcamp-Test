public class Main
{
    public static void main(String[] args) {
        Persona persona = new Persona();
        
        persona.setEdad(33);
        persona.setNombre("Kristian");
        persona.setTelefono("+59389xxxxx2");
        
        System.out.println("Hola " +  persona.getNombre() + "\ntu edad es:" + persona.getEdad() + "\ntu telefono es:" + persona.getTelefono());
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