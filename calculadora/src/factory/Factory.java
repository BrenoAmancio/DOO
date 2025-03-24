package factory;

import model.Operacao;

import java.lang.reflect.InvocationTargetException;

public class Factory {
    public Operacao factory(String tipo){
        Object instancia = null;
        try {
            instancia = Class.forName("model." + tipo).getDeclaredConstructor().newInstance();
        }
        catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
        catch (IllegalAccessException e) {
            e.printStackTrace();
        }
        catch (InstantiationException e) {
            e.printStackTrace();
        }
        catch (NoSuchMethodException e) {
            e.printStackTrace();
        }
        catch (InvocationTargetException e) {
            e.printStackTrace();
        }

        return (Operacao) instancia;
    }
}
