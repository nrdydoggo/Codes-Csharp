using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

public class NameChanger : System.Windows.Forms.Form
{

    //=============���� ����==================
   [STAThreadAttribute]
   static void Main()
    {
        Application.Run(new NameChanger());
        // ��� ���α׷��� ����� �� �Ʒ� �޼��带 ����
        EXIT_PROGRAM ext = new EXIT_PROGRAM();
        ext.EXIT();
    }
    //========================================

    // �� ������ ��
    public NameChanger()
    {

    }
    // �� ���� ���� �޼��� ���� ��


    // �� ���� �˻�, ���� �̸� ���� ���� ��
    /*
      File dir = new File("c:\\");
        
        Scanner sc = new Scanner(System.in);
        
        System.out.println(dir);
      
        File[] files = dir.listFiles();
        ArrayList<String> Fnames = new ArrayList<String>();
        String Search;
        System.out.printf("�˻��� ���ϸ��� �Է��� �ּ���. ==> ");
        Search = sc.nextLine();
        System.out.println();
       //===========���丮 ���ϸ� �ε���============//
        for(int i = 0; i < files.length; i++)
           Fnames.add(files[i].getName());
       //===========================================//
       // ���� �̸� ����ϱ�(+�ð� ���� �޼���)
       /*
       for(int i2 = 0; i2 < files.length; i2++)
       {
           System.out.println(files[i2]);
           try
           {
           Thread.sleep(1000);
           }catch(InterruptedException e)
           {
               e.printStackTrace();
           }
       }
       
        for(int f = 0; f<files.length; f++)
        {
        Boolean isFNameTrue = Fnames.get(f).contains(Search);
        if(isFNameTrue == true)
        {
            System.out.println(Fnames.get(f));
}
        }
       

    */
    //====================���α׷�����=================================//
    public class EXIT_PROGRAM
    {
        public void EXIT()
        {
            Console.WriteLine("���α׷��� �����մϴ�.");
            return;    
        }
    }

    
}