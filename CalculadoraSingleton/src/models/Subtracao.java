package models;

public class Subtracao implements IOperacao {
    private static Subtracao instance = null;

    private Subtracao(){    }

    public static Subtracao getInstance(){
        if (instance == null) {
            instance = new Subtracao();
        }
        return instance;
    }

    public float calcula(float a, float b) {
        return a - b;
    }
}
