public class Coche {

    //atributos que varían para cada objeto coche
    String marca = "";
    Integer numeroPuertas = 0;


    public Coche(String marca, int numeroPuertas) {
        this.marca = marca;
        this.numeroPuertas = numeroPuertas;
    }

    void agregarPuerta(int cantidad) {
        this.numeroPuertas = this.numeroPuertas + cantidad;
    }
}