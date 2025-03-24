package models;

public class Operacao implements IOperacao{
    private IOperacao op;

    public void setOperacao(IOperacao op) {
        this.op = op;
    }

    public float calcula(float a, float b) {
        return op.calcula(a,b);
    }
}
