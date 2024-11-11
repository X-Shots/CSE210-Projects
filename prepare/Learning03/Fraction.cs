public class Fraction{
    private int top;
    private int bottom;


    public Fraction(){
        top = 1;
        bottom = 1;
    }

    public Fraction(int x){
        top = x;
        bottom = 1;
    }

    public Fraction(int x, int y){
        top = x;
        bottom = y;
    }

    public int getTop(){
        return top;
    }

    public void setTop(int x){
        top = x;
    }

    public int getBottom(){
        return bottom;
    }

    public void setBottom(int x){
        bottom = x;
    }


    public string getFractionString(){
        return $"{top}/{bottom}";
    }

    public double getFractionDecimal(){
        return (double)top/bottom;
    }

}