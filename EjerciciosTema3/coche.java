public class Coche {

    //atributos que varían para cada objeto coche
    String marca = "";
    Integer numeroPuertas = 0;


    public Coche(String marca, int numeroPuertas) {
        this.marca = marca;
        this.numeroPuertas = numeroPuertas;
    }

    void agregarPuerta(int cantidad) {
        System.out.println("Se agrego una puerta al coche");
        this.numeroPuertas = this.numeroPuertas + cantidad;
    }
}
