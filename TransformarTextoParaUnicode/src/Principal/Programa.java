package Principal;

public class Programa {

    public static void main(String[] args) {
        String servidor = "asdsws.connesdsdcdsdsdst.psddssddsdb.cloddud:3309";
        String banco = "auditoriafkvjddfdfd";
        String login = "m2hqdfdfjhjdfhdfjdsdsdeuo7h434343433pf";
        String senha = "sdpsdsdcassdsddle_pw_dfffhgfdijrfh84848fZ5cvNqydfdfdfAEHvMimZqmdfdgfdf5";
        
        StringBuilder unicodeString = new StringBuilder();
        
        String nomeVariavelServidor = "r";
        unicodeString.append("private String " + nomeVariavelServidor + " = \"\";");
        unicodeString.append("\n");
        
        String nomeVariavelBanco = "o";
        unicodeString.append("private String " + nomeVariavelBanco + " = \"\";");
        unicodeString.append("\n");
        
        String nomeVariavelLogin = "n";
        unicodeString.append("private String " + nomeVariavelLogin + " = \"\";");
        unicodeString.append("\n");
        
        String nomeVariavelSenha = "a";
        unicodeString.append("private String " + nomeVariavelSenha + " = \"\";");
        unicodeString.append("\n");

        Thread t1 = new Thread(new UnicodeConverter(servidor, nomeVariavelServidor, unicodeString));
        Thread t2 = new Thread(new UnicodeConverter(banco, nomeVariavelBanco, unicodeString));
        Thread t3 = new Thread(new UnicodeConverter(login, nomeVariavelLogin, unicodeString));
        Thread t4 = new Thread(new UnicodeConverter(senha, nomeVariavelSenha, unicodeString));

        t1.start();
        t2.start();
        t3.start();
        t4.start();

        try {
            t1.join();
            t2.join();
            t3.join();
            t4.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        String stringUnicode = unicodeString.toString();
        System.out.println(stringUnicode);
    }

}

class UnicodeConverter implements Runnable {
    private String texto;
    private String nomeVariavel;
    private StringBuilder unicodeString;

    public UnicodeConverter(String texto, String nomeVariavel, StringBuilder unicodeString) {
        this.texto = texto;
        this.nomeVariavel = nomeVariavel;
        this.unicodeString = unicodeString;
    }

    @Override
    public void run() {
        int count = 0;
        for (char c : texto.toCharArray()) {
            synchronized (unicodeString) {
                unicodeString.append(nomeVariavel).append(" += \"\\u").append(String.format("%04x", (int) c));
                unicodeString.append("\";");
                unicodeString.append("\n");
            }
            count++;
            if (count % 4 == 0) {
                synchronized (unicodeString) {
                    unicodeString.append("\n");
                }
            }
            try {
                Thread.sleep(10); // Adiciona um pequeno atraso de 10 milissegundos
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}