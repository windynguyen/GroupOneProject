
package com.vocaro;


import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

public class DataBaseHelper extends SQLiteOpenHelper  
{
	//---------------------Vocabulary----------------------------
	public static final String idvoca = "No_Voca";
	public static final String english_voca = "English";
    public static final String vietnamese_voca = "Vietnamese";
    
    public static final String idpro_voca = "No_Pro";
	public static final String idirr_voca = "No_Irr";
    public static final String idpos_voca = "No_POS";
    
    public static final String idfield_voca = "No_Field";
	public static final String iduser_voca = "No_User";
    //public static final String example_voca = "Examples";
    
    public static final String synonym = "Synonyms";
    public static final String priority = "Priority";
	public static final String creatingdate = "CreatingDate";
	//----------------------------------------------------------
	//---------------------Irregular----------------------------
	public static final String idirr = "No_Irregular";
	public static final String present = "Present";
    public static final String past = "Past";    
    public static final String pastparticiple = "Past_Participle";
	public static final String vietnamese_irr = "Mean";
	//----------------------------------------------------------
	//---------------------Field--------------------------------
	public static final String idfield = "No_Field";
	public static final String namefield = "NameField";
    public static final String description = "Description";
	//----------------------------------------------------------
	//---------------------Learner----------------------------
	public static final String idlearner = "No_Learner";
	//public static final String username = "UserName";
    public static final String password = "PassWord";    
    public static final String firstname = "FirstName";
	public static final String lastname = "LastName";
	//----------------------------------------------------------
	//---------------------Preposition----------------------------
	public static final String idpre = "No_Pre";
	public static final String english_pre = "Preposition";
    public static final String vietnamese_pre = "Mean";    
	//----------------------------------------------------------
	//---------------------Preposition_Voca------ChÆ°a dÃ¹ng tá»›i----------------------
//    public static final String No_PreVoca = "No_PreVoca";
//    public static final String idpre_prevoca = "No_Pre";
//	public static final String idvoca_prevoca = "No_Voca";
//    public static final String vietnamese_prevoca = "Vietnamese";
//    public static final String example_prevoca = "Example";
	//----------------------------------------------------------
	//---------------------Part Of Speech----------------------------
	public static final String idpos = "No_POS";
	public static final String abb = "Abbreviation";
    public static final String pos = "POS";
    public static final String vietnamese_pos = "Vietnamese";
    public static final String Description = "Description";
    public static final String Examples = "Examples";
	//----------------------------------------------------------
	//---------------------Other Part Of Speech----------------------------
//	public static final String No_otherPOS = "No_POS";
//	public static final String idvoca_otherPOS = "No_Voca";
//	public static final String otherPOS_english = "English";
//    public static final String otherPOS_vietnamese = "Vietnamese";
	//----------------------------------------------------------
  //---------------------Pronunciation----------------------------
	public static final String No_Pronun = "No_Pronun";
	public static final String pronun_voca = "Pronunciation";
	public static final String voca_pronun = "English";
	//----------------------------------------------------------	 
	 
	 public static final String DB_NAME = "Vocaro";
	 public static final int DB_VERSION = 2; 
	 private static String DB_PATH = "/data/data/com.vocaro/databases/";
	 
	 public static final String TABLE_Vocabulary = "Vocabularies";
	 public static final String TABLE_Irregular = "Irregulars"; 
	 public static final String TABLE_Field = "Fields";
	 public static final String TABLE_Learner = "Learner";
	 public static final String TABLE_Preposition = "Prepositions";
	 public static final String TABLE_Preposition_Voca = "Preposition_Voca";
	 public static final String TABLE_PartOfSpeech = "PartOfSpeech";
	 public static final String TABLE_Pronun = "Pronunciation";
	 
	 private final Context mContext; 
	 private SQLiteDatabase mDB;
	 
		 public DataBaseHelper(Context context)
		 {
			 super(context, DB_NAME, null, DB_VERSION);
			 this.mContext = context;
			 //mContext.deleteDatabase(DB_NAME);
		 } 
	  
		 public void createDataBase()
		 {
		    	boolean dbExist = checkDataBase();
		    	if(dbExist)
		    	{
		    		//this.getReadableDatabase();
		        	//copyDataBase();
		    		//do nothing - database already exist
		    	}
		    	else
		    	{
		    		//By calling this method and empty database will be created into the default system path
		               //of your application so we are gonna be able to overwrite that database with our database.
		        	this.getReadableDatabase();
		        	copyDataBase();
		    	}
		    }

		     /**
		     * Check if the database already exist to avoid re-copying the file each time you open the application.
		     * @return true if it exists, false if it doesn't
		     */
		    private boolean checkDataBase()
		    {
		    	SQLiteDatabase checkDB = null;
		    	try
		    	{
		    		String myPath = DB_PATH + DB_NAME + ".sqlite";
		    		checkDB = SQLiteDatabase.openDatabase(myPath, null, SQLiteDatabase.OPEN_READONLY);
		    	}
		    	catch(SQLiteException e)
		    	{
		    		//database does't exist yet.
		    	}
		 
		    	if(checkDB != null)
		    	{
		    		checkDB.close();
		    	}
		    	return checkDB != null ? true : false;
		    }

		    /**
		     * Copies your database from your local assets-folder to the just created empty database in the
		     * system folder, from where it can be accessed and handled.
		     * This is done by transfering bytestream.
		     * */
		    private void copyDataBase()
		    {
		 
		    	//Open your local db as the input stream
		    	InputStream myInput;
				try {
					Log.e("rrrr","1111111111111111111");
					myInput = mContext.getAssets().open(DB_NAME+".sqlite");
					
			    	// Path to the just created empty db
					Log.e("errrrrr","2222222222222222");
			    	String outFileName = DB_PATH + DB_NAME + ".sqlite";
			    	Log.e("errrrrr","333333333333333333");
			    	//Open the empty db as the output stream
			    	OutputStream myOutput = new FileOutputStream(outFileName);
			    	Log.e("errrrrr","444444444444444");
			    	//transfer bytes from the inputfile to the outputfile
			    	byte[] buffer = new byte[1024];
			    	int length;
			    	Log.e("errrrrr","555555555555555");
			    	while ((length = myInput.read(buffer))>0)
			    	{
			    		//Log.e("errrrrr","while");
			    		myOutput.write(buffer, 0, length);
			    	}
			    	//Close the streams
			    	Log.e("errrrrr","666666666666666");
			    	myOutput.flush();
			    	myOutput.close();
			    	myInput.close();
				} catch (IOException e) {
					Log.e("ERROR copyDataBase", e.getMessage());
				}
		    }

		    public void openDataBase() throws SQLException
		    {
		    	Log.e("SelectAll",DB_NAME);
		        String myPath = DB_PATH + DB_NAME + ".sqlite";
		    	mDB = SQLiteDatabase.openDatabase(myPath, null, SQLiteDatabase.OPEN_READWRITE);
		    	Log.e("SelectAll2",DB_NAME);
		    }
		    
		    @Override
			public synchronized void close() 
		    {
		    	    if(mDB != null)
		    		    mDB.close();
		    	    super.close();
			}
		        // Add your public helper methods to access and get content from the database.
		       // You could return cursors by doing "return myDataBase.query(....)" so it'd be easy
		       // to you to create adapters for your views.
		    
        @Override 
        public void onCreate(SQLiteDatabase db) { 
            // TODO Auto-generated method stub 
            try 
            { 
            	//createDataBase();
            } 
            catch(SQLException ex) 
            { 
                ex.printStackTrace(); 
            } 
        }  
        
        @Override 
       public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) 
       { 
            Log.i("DBAdapter", "Updating database..."); 
            db.execSQL("DROP TABLE IF EXISTS tblVocabularies");
            db.execSQL("DROP TABLE IF EXISTS tblIrregulars");
            db.execSQL("DROP TABLE IF EXISTS tblFields");
            db.execSQL("DROP TABLE IF EXISTS tblLearners"); 
            db.execSQL("DROP TABLE IF EXISTS tblPrepositions"); 
            db.execSQL("DROP TABLE IF EXISTS tblPreVocas");
            db.execSQL("DROP TABLE IF EXISTS PartOfSpeech");
//	            db.execSQL("DROP TABLE IF EXISTS OtherPOS");
            db.execSQL("DROP TABLE IF EXISTS tblPronunciations");
            onCreate(db); 
        }
        
       public long insert_Vocabulary(VocabulariesClass vc) 
		{
			ContentValues cv = new ContentValues(); 
			
			// 11 thuá»™c tÃ­nh trong Ä‘Ã³ thuá»™c tÃ­nh Id tá»± tÄƒng
			cv.put(english_voca, vc.mEnglish); 
			cv.put(vietnamese_voca, vc.mVietnamese);
			
			cv.put(idpro_voca, vc.mNo_Pro);/////////////////////
			cv.put(idirr_voca,vc.mNo_Irregular); 
			
			cv.put(idpos_voca, vc.mNo_POS); 
			cv.put(idfield_voca, vc.mNo_Field);
			cv.put(iduser_voca, vc.mNo_User);
			
			cv.put(synonym,vc.mSynonym); 
			cv.put(priority, vc.mPriority); 
			cv.put(creatingdate, vc.mCreatingDate);			
			
			return mDB.insert(TABLE_Vocabulary, null, cv);
		} 
	    
	   public long insert_Learner(String _Username, String _Password, String _Firstname, String _Lastname) 
	    {
	        ContentValues cv = new ContentValues(); 
	        cv.put(idlearner,_Username); 
	        cv.put(password, _Password); 
	        cv.put(firstname, _Firstname);
	        cv.put(lastname, _Lastname);
	        return mDB.insert(TABLE_Learner, null, cv);
	    }
	   public long insert_Pronun(String _Voca, String _Pronun) 
	    {
	        ContentValues cv = new ContentValues(); 
	        cv.put(voca_pronun,_Voca); 
	        cv.put(pronun_voca, _Pronun); 
	        return mDB.insert(TABLE_Pronun, null, cv);
	    }
	   
	   public int DeleteAll_Pronun()
	   {
		   return mDB.delete(TABLE_Pronun, null, null);
	   }
	   
	   public long insert_Irregular(String _Present, String _Past, String _Past_Participle, String _Mean) 
	    {
	        ContentValues cv = new ContentValues(); 
	        
	        cv.put(present,_Present); 
	        cv.put(past, _Past); 
	        cv.put(pastparticiple, _Past_Participle);
	        cv.put(vietnamese_irr, _Mean);
	        
	        return mDB.insert(TABLE_Irregular, null, cv);
	    }
	   public long insert_Field(String _NameField, String _Desciption) 
	    {
	        ContentValues cv = new ContentValues(); 
	        cv.put(namefield,_NameField); 
	        cv.put(description, _Desciption); 
	        return mDB.insert(TABLE_Field, null, cv);
	    }
	   
	   public long insert_Preposition(String _Preposition, String _Mean) 
	    {
	        ContentValues cv = new ContentValues(); 
	        cv.put(english_pre,_Preposition); 
	        cv.put(vietnamese_pre, _Mean); 
	        return mDB.insert(TABLE_Preposition, null, cv);
	    }
	   
	   public long insert_PartOfSpeech(String _Abbreviation, String _POS, String _Vietnamese) 
	    {
	        ContentValues cv = new ContentValues(); 
	        cv.put(abb, _Abbreviation); 
	        cv.put(pos, _POS);
	        cv.put(vietnamese_pos, _Vietnamese);
	        return mDB.insert(TABLE_Learner, null, cv);
	    }
	      
	    public void DeleteById(String Table, String No_name, int _Id) 
	    { 
	        mDB.delete(Table, No_name + "=" + _Id, null);
	    }
	    
	    public int DeleteAll(String Table) 
	    {
	    	 return mDB.delete(Table, null, null);
	    }
	    
	    public Cursor SelectAll(String table)
	    {  
	    	Log.e("SelectAll",table);
	        return mDB.rawQuery("Select * From " + table +  ";" , null);
	    }
	      
	    public Cursor SelectByID(String Table, String No_name, String _Id)
	    { 
	    	Cursor mCursor = mDB.rawQuery("Select * From " + Table + " Where " + No_name + "=" + _Id + ";" , null);
	    	if(mCursor != null) 
	        {
	            mCursor.moveToFirst(); 
	        }
	        return mCursor; 
	    }
	    public Cursor SelectByName(String table, String column, String name) //Kiá»ƒm tra tá»« vá»±ng Ä‘Ã£ cÃ³ trong DB chÆ°a (DÃ¹ng cho hÃ m Leave edtEnglish khi Add Voca)
	    { 
	    	Cursor mCursor = mDB.rawQuery("Select * From " + table + " Where " + column + " like '"+ name +"';" , null);
	    	if(mCursor != null) 
	        {
	            mCursor.moveToFirst(); 
	        }
	        return mCursor; 
	    }
	    
	    public Cursor SelectByNameIrr(String name)
	    { 
	    	Cursor mCursor = mDB.rawQuery("Select * From " + TABLE_Irregular + " Where " + present + " like '"+ name +"' or " + past + " like '"+ name +"' or " + pastparticiple + " like '"+ name +"';" , null);
	    	if(mCursor != null) 
	        {
	            mCursor.moveToFirst(); 
	        }
	        return mCursor; 
	    }
	    public Cursor SelectVoca_First(String No_Voca)
	    { 
	    	
	    	Cursor mCursor = mDB.rawQuery("SELECT V.English, POS.Addreviation, V.Vietnamese, F.NameField, I.Present, I.Past, I.Past_Participle FROM Vocabularies V, PartOfSpeech POS, Fields F, Irregulars I Where V.No_Voca = '"+No_Voca+"' And V.No_Irr = I.No_Irregular And V.No_POS = POS.No_POS And V.No_Field= F.No_Field" , null);
	    	if(mCursor != null) 
	        {
	            mCursor.moveToFirst(); 
	        }
	        return mCursor; 
	    }
	    public Cursor SelectVoca_Second(String No_Voca)
	    { 
	    	Log.e("Cursor","xxxxxxxxxxxxxxxxxxxxxxxxx");
	    	Cursor mCursor = mDB.rawQuery("SELECT P.Prepositon, PV.Mean, PV.Example FROM Prepositon_Voca PV, Prepositions P Where PV.No_Voca = '"+No_Voca+"' And PV.No_Pre = P.No_Pre" , null);
	    	Log.e("Cursor","yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
	    	if(mCursor != null) 
	        {
	            mCursor.moveToFirst(); 
	        }
	        return mCursor; 
	    }
}










