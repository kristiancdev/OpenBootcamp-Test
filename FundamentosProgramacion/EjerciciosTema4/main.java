
/*
Online Java - IDE, Code Editor, Compiler

Online Java is a quick and easy tool that helps you to build, compile, test your programs online.
*/

public class Main
{
    public static void main(String[] args) {
        System.out.println("Primera parte If");
        condicional(5-5);
        
        System.out.println("Segunda parte While");
        bucleWhile();
        
        System.out.println("Tercera parte Do While");
        bucleDoWhile();
        
        System.out.println("Cuarta parte For");
        bucleFor();
        
        System.out.println("Quinta parte Switch");
        condicionalSwitch();
    }
    
    static void condicional(int numero){
        if(numero>0){
            System.out.println("Positivo");
        }else if(numero==0){
            System.out.println("Es cero");
        }else{
            System.out.println("Negativo");
        }
    }
    
    static void bucleWhile(){
        int numeroWhile = 0;
        while(numeroWhile < 3){
            numeroWhile = numeroWhile+1;
            System.out.println(numeroWhile);
        }
    }
    
    static void bucleDoWhile(){
        int numeroWhile = 4;
        do{
            numeroWhile = numeroWhile+1;
            System.out.println(numeroWhile);
        }while(numeroWhile < 3);
    }
    
    static void bucleFor(){
        for (int numeroFor = 0; numeroFor <= 3; numeroFor++) {
             System.out.println(numeroFor);
        }
    }
    
    static void condicionalSwitch(){
        String estacion = "Verano";
        
        switch(estacion){
            case "Invierno":
                System.out.println("La estacion del año es: " + estacion);
                break;
            case "Privamera":
                System.out.println("La estacion del año es: " + estacion);
                break;
            case "Verano":
                System.out.println("La estacion del año es: " + estacion);
                break;
            case "Otoño":
               System.out.println("La estacion del año es: " + estacion);
                break;
            default: 
                System.out.println(estacion + ": no es una estación.");
        }
    }
}
