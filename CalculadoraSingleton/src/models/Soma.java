package models;

public class Soma implements IOperacao {
    private static Soma instance = null;

    private Soma(){    }

    public static Soma getInstance(){
        if (instance == null) {
            instance = new Soma();
        }
        return instance;
    }

    public float calcula(float a, float b) {
        return a + b;
    }
}
