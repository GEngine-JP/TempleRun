using System;
using System.Collections.Generic;
using System.Text;

namespace KTV.KTVclass
{
	public class tb_authorinfo
	{
		 private string authorId;
		 public string intauthorId
			 {
				 get{ return authorId;}
				 set{ authorId=value;}
			 }
		 private string authorName;
		 public string strauthorName
			 {
				 get{ return authorName;}
				 set{ authorName=value;}
			 }
		 private string authorSex;
		 public string strauthorSex
			 {
				 get{ return authorSex;}
				 set{ authorSex=value;}
			 }
		 private DateTime authorbirthday;
		 public DateTime daauthorbirthday
			 {
				 get{ return authorbirthday;}
				 set{ authorbirthday=value;}
			 }
		 private string authorGenre;
		 public string strauthorGenre
			 {
				 get{ return authorGenre;}
				 set{ authorGenre=value;}
			 }
		 private string authorcompany;
		 public string strauthorcompany
			 {
				 get{ return authorcompany;}
				 set{ authorcompany=value;}
			 }
		 private byte[]authorPhoto;
		 public byte[] bytauthorPhoto
			 {
				 get{ return authorPhoto;}
				 set{ authorPhoto=value;}
			 }
		 private string authorRecma;
		 public string strauthorRecma
			 {
				 get{ return authorRecma;}
				 set{ authorRecma=value;}
			 }
		 private string authorzjm;
		 public string strauthorzjm
			 {
				 get{ return authorzjm;}
				 set{ authorzjm=value;}
			 }
		 private DateTime RdateTime;
		 public DateTime daRdateTime
			 {
				 get{ return RdateTime;}
				 set{ RdateTime=value;}
			 }
	} 
}