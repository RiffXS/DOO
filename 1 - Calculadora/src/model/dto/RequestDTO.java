package model.dto;

public class RequestDTO {

    private String option;
    private float value1;
    private float value2;

    public RequestDTO(String option, float value1, float value2) {
        this.option = option;
        this.value1 = value1;
        this.value2 = value2;
    }

    public String getOption() {
        return option;
    }

    public void setOption(String option) {
        this.option = option;
    }

    public float getValue1() {
        return value1;
    }

    public void setValue1(float value1) {
        this.value1 = value1;
    }

    public float getValue2() {
        return value2;
    }

    public void setValue2(float value2) {
        this.value2 = value2;
    }

}
