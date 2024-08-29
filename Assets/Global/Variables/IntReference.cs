using System;

[Serializable]
public class IntReference
{
   public bool UseConstant = false;
   public int ConstantValue;
   public IntVariable Variable;

   public int Value 
   {
        get { return UseConstant ? ConstantValue : Variable.Value; }
   }
}
