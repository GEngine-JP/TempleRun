using System;
using System.Collections.Generic;
using System.Text;

namespace KTV.KTVclass
{
	public class tb_musicinfo
	{
      
		
        //�������
		 private string Music_code;
		 public string strMusic_code
			 {
				 get{ return Music_code;}
				 set{ Music_code=value;}
			 }
        //��������
		 private string MusicC_name;
		 public string strMusicC_name
			 {
				 get{ return MusicC_name;}
				 set{ MusicC_name=value;}
			 }
        //�ݳ�����
		 private string Music_author;
		 public string strMusic_author
			 {
				 get{ return Music_author;}
				 set{ Music_author=value;}
			 }
          //������
		 private string Music_Kind;
		 public string strMusic_Kind
			 {
				 get{ return Music_Kind;}
				 set{ Music_Kind=value;}
			 }
        //����
		 private string Music_chinse;
		 public string strMusic_chinse
			 {
				 get{ return Music_chinse;}
				 set{ Music_chinse=value;}
			 }
        //�����ļ�·��
		 private string Music_filepath;
		 public string strMusic_filepath
			 {
				 get{ return Music_filepath;}
				 set{ Music_filepath=value;}
			 }
        //����������д
		 private string Music_Ping;
		 public string strMusic_Ping
			 {
				 get{ return Music_Ping;}
				 set{ Music_Ping=value;}
			 }
        //¼��ʱ��
		 private DateTime Music_date;
		 public DateTime daMusic_date
			 {
				 get{ return Music_date;}
				 set{ Music_date=value;}
			 }
        //ɾ�����
		 private int Music_falg;
		 public int intMusic_falg
			 {
				 get{ return Music_falg;}
				 set{ Music_falg=value;}
			 }
	} 
}