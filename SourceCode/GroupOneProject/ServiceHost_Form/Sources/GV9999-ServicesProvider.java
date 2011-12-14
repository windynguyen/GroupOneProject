package com.vocaro;

import java.util.Calendar;
import java.util.Date;

import android.text.method.DateTimeKeyListener;

public class ServicesProvider 
{
	public String CapitalLetter(String voca) // Đổi chữ cái đầu tiên trong chuỗi thành chữ hoa
	{
		if(voca!="")
		{
			String FirstStr;
			String LastStr;
			voca = voca.trim();
			String UpperVoca = voca.toUpperCase();
			FirstStr = UpperVoca.substring(0, 1);
			LastStr = voca.substring(1);
			return voca = FirstStr + LastStr;
		}
		else
		{
			return "";
		}
	}
	
	public String[] Vina;
	public String[] Syno;
	
	public String[] Split_Vina(String voca) // Đưa tiếng việt về dạng chuẩn để insert vào DB
	{
		Vina = new String[10];
		Vina = voca.split(",", 10);
		for(int i=0;i<Vina.length;i++)
		{
			Vina[i] = CapitalLetter(Vina[i]);
		}
		return Vina;
	}
	public String[] Split_Synonym(String voca) // Đưa Synonym về dạng chuẩn để insert vào DB
	{
		Syno = new String[10];
		Syno = voca.split(",", 10);
		for(int i=0;i<Syno.length;i++)
		{
			Syno[i] = CapitalLetter(Syno[i]);
		}
		return Syno;
	}
	
    public String GeneratingCode(String Voca)
    {
        //Capture two first chars of Vocabulary plus a random String
        String Code;
        Date cal=Calendar.getInstance().getTime();

        Code = Voca.substring(0, 2);
        Code += cal.getHours() + cal.getMinutes() + cal.getSeconds();
        return Code;
    }
}
