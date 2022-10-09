/*
Online Java - IDE, Code Editor, Compiler

Online Java is a quick and easy tool that helps you to build, compile, test your programs online.
*/

public class Main
{
    public static void main(String[] args) {
        System.out.println("------------- Primera Parte -------------");
        System.out.println("La suma es de los tres números es:" + sumaNumeros(2,3,5));
        
        System.out.println("------------- Segunda Parte -------------");
        Coche coche = new Coche("Honda", 4);
        
        System.out.println("Numero de puertas: " + Integer.toString(coche.numeroPuertas));
        coche.agregarPuerta(1);
        System.out.println("Numero de puertas: " + Integer.toString(coche.numeroPuertas));
    }
    
    static int sumaNumeros(int numero1, int numero2, int numero3){
        return (numero1+numero2+numero3);
    } 
}
