package model.factories;

public interface IFactory<T> {
    T create(String option);
}
