package model.operations;

public class Addition implements IOperation {
    @Override
    public float operation(float a, float b) {
        return a + b;
    }
}
