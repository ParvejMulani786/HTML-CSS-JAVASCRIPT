import java.util.*;
public class FindDuplicate {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter String :");
		String str=sc.nextLine();
		String[] strArr=str.split(" ");
		for(int i=0;i<strArr.length;i++){
			String s=strArr[i];
			String res=findDuplicate(s);
		System.out.println(strArr[i]+":" +res);
			
		}
		
		

	}
	public static String findDuplicate(String str){
		String res="";
		HashMap<Character,Integer> map=new HashMap<>();
		for(int i=0;i<str.length();i++){
			if(!map.containsKey(str.charAt(i))){
				map.put(str.charAt(i),1);
			}else{
				map.put(str.charAt(i),(map.get(str.charAt(i)))+1);
			}
			
		}
		for(Map.Entry it:map.entrySet()){
			
			char ch=(char)it.getKey();
			int count=(int)it.getValue();
			if(count>1){
				res+=ch+": "+count+" ";
				//System.out.print( res);
			}
			
		}
		return res;
		
	}

}
