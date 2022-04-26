using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

public class NameChanger : System.Windows.Forms.Form
{

    //=============시작 지점==================
   [STAThreadAttribute]
   static void Main()
    {
        Application.Run(new NameChanger());
        // 모든 프로그램이 종료된 후 아래 메서드를 실행
        EXIT_PROGRAM ext = new EXIT_PROGRAM();
        ext.EXIT();
    }
    //========================================

    // ▼ 생성자 ▼
    public NameChanger()
    {

    }
    // ▼ 파일 오픈 메서드 구간 ▼


    // ▼ 파일 검색, 파일 이름 수정 구간 ▼
    /*
      File dir = new File("c:\\");
        
        Scanner sc = new Scanner(System.in);
        
        System.out.println(dir);
      
        File[] files = dir.listFiles();
        ArrayList<String> Fnames = new ArrayList<String>();
        String Search;
        System.out.printf("검색할 파일명을 입력해 주세요. ==> ");
        Search = sc.nextLine();
        System.out.println();
       //===========디렉토리 파일명 인덱싱============//
        for(int i = 0; i < files.length; i++)
           Fnames.add(files[i].getName());
       //===========================================//
       // 파일 이름 출력하기(+시간 지연 메서드)
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
    //====================프로그램종료=================================//
    public class EXIT_PROGRAM
    {
        public void EXIT()
        {
            Console.WriteLine("프로그램을 종료합니다.");
            return;    
        }
    }

    
}