package models;

public class Multiplicacao implements IOperacao {
    private static Multiplicacao instance = null;

    private Multiplicacao(){    }

    public static Multiplicacao getInstance(){
        if (instance == null) {
            instance = new Multiplicacao();
        }
        return instance;
    }
    public float calcula(float a, float b) {
        return a * b;
    }
}
