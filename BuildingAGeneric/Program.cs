using System;


public interface IValidatable
{
   public bool IsValid();
}

public class ValidatableAmount : IValidatable
{
  private decimal _value;
  private decimal _min;
  private decimal _max;
  
  public bool IsValid(){
    if(this._value>=this._min && this._value<=this._max){
      return true;
    }else{
      return false;
    }
  }
  public ValidatableAmount(decimal value, decimal min, decimal max)
  {
    this._value = value;
    this._min = min;
    this._max = max;
    IsValid();
  }
}
public class SafeValue<T> where T : IValidatable
{
    private T _value;

    public bool IsValid(){
    return _value != null;
  }
    public SafeValue(T initialValue){
      if(initialValue != null && initialValue.IsValid()){
        _value = initialValue;
      }else{
      throw new ArgumentException();
      }
    }

    public T GetValue(){return _value;}

    public void SetValue(T value){
      if(IsValid()==true){
       _value = value;
      }else{
        throw new ArgumentException();
      }
    }

    public bool HasValue(){
      if(_value is not null){
        return true;
      }
      return false;
    }

}

class Program 
{
  static void Main()
  {
        //SafeValue<int> testValue = new SafeValue<int>(42);
        //Console.WriteLine(testValue.GetValue());
        //testValue.SetValue(100);
        //Console.WriteLine(testValue.GetValue());
        try{
        ValidatableAmount val = new ValidatableAmount(50,0,100);
        SafeValue<ValidatableAmount> val1 = new SafeValue<ValidatableAmount>(val);
        val1.SetValue(val);
        Console.WriteLine(val1.GetValue());
        }catch (ArgumentException ex){
          Console.WriteLine("Invalid: " + ex.Message);
        }

      
  }
}
