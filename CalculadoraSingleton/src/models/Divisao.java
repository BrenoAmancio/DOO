package models;

public class Divisao implements IOperacao {
    private static Divisao instance = null;

    private Divisao(){    }

    public static Divisao getInstance(){
        if (instance == null) {
            instance = new Divisao();
        }
        return instance;
    }
    public float calcula(float a, float b) {
        return a / b;
    }
}
