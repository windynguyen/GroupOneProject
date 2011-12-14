package com.vocaro;

import java.util.Calendar;

import android.app.AlarmManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.widget.Toast;

public class LearningAlarm {
	private Context mContext;
	public LearningAlarm (Context cont) {
		mContext = cont;
	}
	private PendingIntent pendingIntent;
	 public void setAlarm(int second) {
    	Intent alarmIntent = new Intent(mContext, LearningAlarmService.class);
    	alarmIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);//�Importance//
        pendingIntent = PendingIntent.getService(mContext, 0, alarmIntent, 0);
        AlarmManager alarmManager = (AlarmManager)mContext.getSystemService(mContext.ALARM_SERVICE);
        
        Calendar calendar = Calendar.getInstance();
        calendar.setTimeInMillis(System.currentTimeMillis());
        calendar.add(Calendar.SECOND, second);
        
        alarmManager.set(AlarmManager.RTC_WAKEUP, calendar.getTimeInMillis(), pendingIntent);
        
        Toast.makeText(mContext, "Alarm begin after: "+ String.valueOf(second)+ "s" , Toast.LENGTH_SHORT).show();
	}
	 
	
}


