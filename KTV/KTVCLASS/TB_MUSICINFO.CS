using System;
using System.Collections.Generic;
using System.Text;

namespace KTV.KTVclass
{
	public class tb_musicinfo
	{
      
		
        //歌曲编号
		 private string Music_code;
		 public string strMusic_code
			 {
				 get{ return Music_code;}
				 set{ Music_code=value;}
			 }
        //歌曲名称
		 private string MusicC_name;
		 public string strMusicC_name
			 {
				 get{ return MusicC_name;}
				 set{ MusicC_name=value;}
			 }
        //演唱歌手
		 private string Music_author;
		 public string strMusic_author
			 {
				 get{ return Music_author;}
				 set{ Music_author=value;}
			 }
          //歌典类别
		 private string Music_Kind;
		 public string strMusic_Kind
			 {
				 get{ return Music_Kind;}
				 set{ Music_Kind=value;}
			 }
        //语言
		 private string Music_chinse;
		 public string strMusic_chinse
			 {
				 get{ return Music_chinse;}
				 set{ Music_chinse=value;}
			 }
        //歌曲文件路径
		 private string Music_filepath;
		 public string strMusic_filepath
			 {
				 get{ return Music_filepath;}
				 set{ Music_filepath=value;}
			 }
        //歌曲名子缩写
		 private string Music_Ping;
		 public string strMusic_Ping
			 {
				 get{ return Music_Ping;}
				 set{ Music_Ping=value;}
			 }
        //录入时间
		 private DateTime Music_date;
		 public DateTime daMusic_date
			 {
				 get{ return Music_date;}
				 set{ Music_date=value;}
			 }
        //删除标记
		 private int Music_falg;
		 public int intMusic_falg
			 {
				 get{ return Music_falg;}
				 set{ Music_falg=value;}
			 }
	} 
}