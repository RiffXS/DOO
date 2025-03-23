package model.factories;

import model.operations.IOperation;

public class OperationFactory extends AbstractFactory<IOperation> {
    public OperationFactory() {
        super.basePackage = super.basePackage + "operations.";
    }
}
