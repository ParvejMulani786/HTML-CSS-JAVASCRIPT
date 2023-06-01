class RemoveDuplicate{
public static void main(String[] args){
String str="aafeefrttyyxx";
removeDuplicate(str);
}
public static void removeDuplicate(String s){
String res="";
int j=0,i=0;
while(j<s.length()){
if(s.charAt(i)==s.charAt(j)){
j++;
}else{
if(s.charAt(j)!=s.charAt(i) || j==s.length()-1){
res+=s.charAt(i);
i=j;
j++;
}
}
//add last element


}
res+=s.charAt(s.length()-1);
System.out.println(res);
}
}