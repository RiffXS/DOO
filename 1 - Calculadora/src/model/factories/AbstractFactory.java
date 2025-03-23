package model.factories;

import model.exception.InvalidFactoryException;

import java.lang.reflect.InvocationTargetException;

public class AbstractFactory<T> implements IFactory<T> {
    protected String basePackage = "model.";

    @Override
    public T create(String option) {
        T t;

        try {
            String basePackage = this.basePackage + option;

            Class<?> operationClass = Class.forName(basePackage);
            t = (T) operationClass.getDeclaredConstructor().newInstance();

        } catch (ClassNotFoundException | NoSuchMethodException | IllegalAccessException | InstantiationException |
                 InvocationTargetException | SecurityException e) {
            throw new InvalidFactoryException("Error trying to create instance via factories: " + e.getMessage());
        }

        return t;
    }
}
