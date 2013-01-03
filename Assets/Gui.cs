using UnityEngine;
using LitJson;
using System;
using System.Collections;

public class Gui : MonoBehaviour {
	
	private string json;
	//private string building="";
	string s = "A111";
	private float H;
	private float V;
	private Vector3 newPos= Vector3.zero;
	private Vector3 startPos = Vector3.zero;
	
	private Vector3 markerPos = Vector3.zero;

	void Start(){
		
		json = @"{""rooms"":[{""code"":""A111"",""name"":""Aristoteles1"",""latitude"":""785582"",""longitude"":""9978276""},{""code"":""A112"",""name"":""Aristoteles1"",""latitude"":""785328"",""longitude"":""9978101""},{""code"":""A113"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978132""},{""code"":""A114"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978141""},{""code"":""A115"",""name"":""Aristoteles"",""latitude"":""785348"",""longitude"":""9978158""},{""code"":""A201"",""name"":""Aristoteles"",""latitude"":""785325"",""longitude"":""9978147""},{""code"":""A202"",""name"":""Aristoteles"",""latitude"":""785325"",""longitude"":""9978144""},{""code"":""A117"",""name"":""Aristoteles"",""latitude"":""785325"",""longitude"":""9978128""},{""code"":""A103"",""name"":""Aristoteles"",""latitude"":""785325"",""longitude"":""9978121""},{""code"":""TeatroCB"",""name"":""Casa Blanca"",""latitude"":null,""longitude"":null},{""code"":""CB101"",""name"":""Casa Blanca"",""latitude"":""785526"",""longitude"":""9978225""},{""code"":""CB102"",""name"":""Casa Blanca"",""latitude"":""785526"",""longitude"":""9978231""},{""code"":""CB103"",""name"":""Casa Blanca"",""latitude"":""785526"",""longitude"":""9978224""},{""code"":""CB104"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978224""},{""code"":""CB105B"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978229""},{""code"":""CB108"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978229""},{""code"":""C101"",""name"":""Ciceron"",""latitude"":null,""longitude"":null},{""code"":""C301"",""name"":""Ciceron"",""latitude"":null,""longitude"":null},{""code"":""C304"",""name"":""Ciceron"",""latitude"":null,""longitude"":null},{""code"":""C305"",""name"":""Ciceron"",""latitude"":null,""longitude"":null},{""code"":""GAC1"",""name"":""Ciceron"",""latitude"":null,""longitude"":null},{""code"":""GAC2"",""name"":""Ciceron"",""latitude"":null,""longitude"":null},{""code"":""TeatroC"",""name"":""Ciceron Teatro Calderon de la Barca"",""latitude"":null,""longitude"":null},{""code"":""Aula1"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""Aula2"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""Aula3"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""Aula4"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""Aula5"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""Aula6"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""D101"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D102"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D108"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D112"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D117"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D118"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D119"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D120"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D121"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D200"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D206"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D210"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D215"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D216"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D217"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D218"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D219"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D301"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D303"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D307"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D312"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D313"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""D315"",""name"":""Davinci"",""latitude"":null,""longitude"":null},{""code"":""EP34"",""name"":""Epicuro"",""latitude"":null,""longitude"":null},{""code"":""EP35"",""name"":""Epicuro"",""latitude"":null,""longitude"":null},{""code"":""TeatroEP"",""name"":""Epicuro"",""latitude"":null,""longitude"":null},{""code"":""EE208"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE310"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE311"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""A101"",""name"":""Aristoteles"",""latitude"":""785348"",""longitude"":""9978131""},{""code"":""A106"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978131""},{""code"":""A102"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978124""},{""code"":""A102A"",""name"":""Aristoteles"",""latitude"":""785325"",""longitude"":""9978122""},{""code"":""A103A"",""name"":""Aristoteles"",""latitude"":""785325"",""longitude"":""9978125""},{""code"":""A104"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978126""},{""code"":""A105"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978135""},{""code"":""A118"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978128""},{""code"":""A107"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978133""},{""code"":""A108"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978136""},{""code"":""DW012"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW011"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW010"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW009"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW007"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW018"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW016"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW102"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW103"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW107"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW108"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW203"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW204"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW003"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW022"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""DW101"",""name"":""Charles Darwin"",""latitude"":null,""longitude"":null},{""code"":""LT101A"",""name"":""LaoTse"",""latitude"":null,""longitude"":null},{""code"":""N101"",""name"":""Newton"",""latitude"":""785459"",""longitude"":""9978240""},{""code"":""N102"",""name"":""Newton"",""latitude"":""785459"",""longitude"":""9978227""},{""code"":""N202"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N105"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978246""},{""code"":""N106"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978242""},{""code"":""N201"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N201.1"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N203"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N204"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N206"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N207"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N209"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N210"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N211"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N213"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978243""},{""code"":""N302"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978249""},{""code"":""N214"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978246""},{""code"":""N216"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978250""},{""code"":""N219"",""name"":""Newton"",""latitude"":""785459"",""longitude"":""9978257""},{""code"":""N104C"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978231""},{""code"":""N104D"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978228""},{""code"":""N104E"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978221""},{""code"":""N104I"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N104G"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978223""},{""code"":""N111"",""name"":""Newton"",""latitude"":""785459"",""longitude"":""9978257""},{""code"":""N300"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978244""},{""code"":""N301"",""name"":""Newton"",""latitude"":""785470"",""longitude"":""9978259""},{""code"":""N301A"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978254""},{""code"":""N305"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978244""},{""code"":""N306"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978243""},{""code"":""N310"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N103"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978241""},{""code"":""N104"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978226""},{""code"":""N104A"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978223""},{""code"":""N104B"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978221""},{""code"":""N104F"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978227""},{""code"":""N104K"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978222""},{""code"":""N109"",""name"":""Newton"",""latitude"":""785470"",""longitude"":""9978256""},{""code"":""N111A"",""name"":""Newton"",""latitude"":""785459"",""longitude"":""9978260""},{""code"":""N111B"",""name"":""Newton"",""latitude"":""785470"",""longitude"":""9978262""},{""code"":""N111C"",""name"":""Newton"",""latitude"":""785470"",""longitude"":""9978260""},{""code"":""N111E"",""name"":""Newton"",""latitude"":""785470"",""longitude"":""9978259""},{""code"":""N200"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N205"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N208"",""name"":""Newton"",""latitude"":null,""longitude"":null},{""code"":""N212"",""name"":""Newton"",""latitude"":""785459"",""longitude"":""9978252""},{""code"":""N215"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978247""},{""code"":""N217"",""name"":""Newton"",""latitude"":""785470"",""longitude"":""9978255""},{""code"":""N300A"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978243""},{""code"":""N304"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978246""},{""code"":""N307"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978242""},{""code"":""N309"",""name"":""Newton"",""latitude"":""785481"",""longitude"":""9978239""},{""code"":""N308"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978238""},{""code"":""LT100A"",""name"":""LaoTse"",""latitude"":null,""longitude"":null},{""code"":""LT100B"",""name"":""LaoTse"",""latitude"":null,""longitude"":null},{""code"":""LT101B"",""name"":""LaoTse"",""latitude"":null,""longitude"":null},{""code"":""M101"",""name"":""Mozart"",""latitude"":null,""longitude"":null},{""code"":""M102"",""name"":""Mozart"",""latitude"":null,""longitude"":null},{""code"":""M103"",""name"":""Mozart"",""latitude"":null,""longitude"":null},{""code"":""M104"",""name"":""Mozart"",""latitude"":null,""longitude"":null},{""code"":""M106"",""name"":""Mozart"",""latitude"":null,""longitude"":null},{""code"":""PF109"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""EE304"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE207"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE200"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE202"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE203"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE204"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE205"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE209"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE301"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE305"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE308"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""EE309"",""name"":""Eugenio Espejo"",""latitude"":null,""longitude"":null},{""code"":""GA12"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""GA13"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""GA14"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""GA15"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""GA16"",""name"":""Gacebo"",""latitude"":""785537"",""longitude"":""9978224""},{""code"":""GA10"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""GA11"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""CB107"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978224""},{""code"":""CB109"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978234""},{""code"":""CB110"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978231""},{""code"":""CB106"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978222""},{""code"":""CB111"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978231""},{""code"":""CB112"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978232""},{""code"":""PF110"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""PF111"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""PF112"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""GA1"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""GA2"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""GA3"",""name"":""Gacebo"",""latitude"":null,""longitude"":null},{""code"":""G103"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G108"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G109"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G110"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G203"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G204"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G205"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G207"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G208"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G300"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G304"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G315"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G107"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G100A"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G100B"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G107A"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G206"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G305"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G317"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G318"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G100"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G100C"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G101"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G102"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G105"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G106A"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G106B"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G202"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G206A"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G206B"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G207B"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G301"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G302"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G303"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G305A"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G305B"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G305C"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G305D"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G306"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G306A"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G306B"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G307"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G308"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G309"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G310"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G311"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G312"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G313"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G314"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G316"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""G319"",""name"":""Galileo"",""latitude"":null,""longitude"":null},{""code"":""E202"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978274""},{""code"":""E203"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978268""},{""code"":""E400"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978275""},{""code"":""E401"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978287""},{""code"":""E402"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978283""},{""code"":""E100"",""name"":""Einstein"",""latitude"":""785459"",""longitude"":""9978283""},{""code"":""E101"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978284""},{""code"":""E102"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978284""},{""code"":""E103"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978283""},{""code"":""E104"",""name"":""Einstein"",""latitude"":""785459"",""longitude"":""9978275""},{""code"":""E105"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978274""},{""code"":""E201"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978279""},{""code"":""E301"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978283""},{""code"":""E301D"",""name"":""Einstein"",""latitude"":""785459"",""longitude"":""9978284""},{""code"":""E301E"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978283""},{""code"":""E302"",""name"":""Einstein"",""latitude"":null,""longitude"":null},{""code"":""E303"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978288""},{""code"":""E104A"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978272""},{""code"":""E104B"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978271""},{""code"":""E104C"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978268""},{""code"":""E104D"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978266""},{""code"":""E301A"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978285""},{""code"":""E301C"",""name"":""Einstein"",""latitude"":""785459"",""longitude"":""9978283""},{""code"":""E302A"",""name"":""Einstein"",""latitude"":null,""longitude"":null},{""code"":""E304"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978283""},{""code"":""CT100"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT101"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT102"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT104"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT105"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT106"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT201"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT300"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT301"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT302"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT103"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT200"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CT202"",""name"":""Casa Tomate"",""latitude"":null,""longitude"":null},{""code"":""CC104"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC106"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC107"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC109"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC202"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC205"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC101"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC102"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC103"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC105"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC108"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC201"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC203"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""CC204"",""name"":""Casa Corona"",""latitude"":null,""longitude"":null},{""code"":""AM100"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""TaeKwonDo"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""AM201"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""AM202"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""AM203"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""AM204"",""name"":""Coliseo"",""latitude"":null,""longitude"":null},{""code"":""B2"",""name"":""Pagoda"",""latitude"":null,""longitude"":null},{""code"":""B1"",""name"":""Pagoda"",""latitude"":null,""longitude"":null},{""code"":""B0"",""name"":""Pagoda"",""latitude"":null,""longitude"":null},{""code"":""B0.0"",""name"":""Pagoda"",""latitude"":null,""longitude"":null},{""code"":null,""name"":null,""latitude"":null,""longitude"":null},{""code"":""Aula2B"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""Aula2A"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""Aula3B"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""Aula3A"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""BS104"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS105"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS201"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS205"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS207"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M001"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M002"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M003"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M007"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M105"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M107"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M108"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M113"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M114"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M115"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M202"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M203"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M210"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M211A"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M213"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M216"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M217"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M302"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M303"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M309"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M310"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M311"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M312"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M318"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M321"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M324"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""IMCA"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""IMCB"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""IMCC"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS101"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS106"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M103A"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M109"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M110"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M111"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M201"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M204"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M205"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M207"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M208"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M209"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M215"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M216A"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M218"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M220"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M221"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M304"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M305"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M306"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M307"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M308"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M322"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M323"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS103"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS102"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""M301"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS202"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS203"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS204"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS206"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""BS208"",""name"":""Maxwell"",""latitude"":null,""longitude"":null},{""code"":""430"",""name"":null,""latitude"":null,""longitude"":null},{""code"":""EE206"",""name"":""Eugenio Espejo"",""latitude"":""785381"",""longitude"":""9978166""},{""code"":""A102B"",""name"":""Aristoteles"",""latitude"":""785336"",""longitude"":""9978121""},{""code"":null,""name"":null,""latitude"":""785336"",""longitude"":""9978142""},{""code"":""Carpinteria"",""name"":""Carpinteria"",""latitude"":""785325"",""longitude"":""9978170""},{""code"":""Copiadora"",""name"":""Copiadora"",""latitude"":""785325"",""longitude"":""9978153""},{""code"":""Xerox"",""name"":""Xerox"",""latitude"":""785481"",""longitude"":""9978250""},{""code"":""E200"",""name"":""Einstein"",""latitude"":""785481"",""longitude"":""9978287""},{""code"":""E300"",""name"":""Einstein"",""latitude"":""785470"",""longitude"":""9978286""},{""code"":""Wifi"",""name"":""Sistemas"",""latitude"":""785481"",""longitude"":""9978287""},{""code"":""CB105A"",""name"":""Casa Blanca"",""latitude"":""785537"",""longitude"":""9978229""},{""code"":""MS004"",""name"":""Miguel de Santiago"",""latitude"":""785348"",""longitude"":""9978172""},{""code"":""MS001"",""name"":""Miguel de Santiago"",""latitude"":""785336"",""longitude"":""9978180""},{""code"":""MS003"",""name"":""Miguel de Santiago"",""latitude"":""785325"",""longitude"":""9978173""},{""code"":""MS200"",""name"":""Miguel de Santiago"",""latitude"":""785336"",""longitude"":""9978181""},{""code"":""MS201"",""name"":""Miguel de Santiago"",""latitude"":""785336"",""longitude"":""9978178""},{""code"":""MS202"",""name"":""Miguel de Santiago"",""latitude"":""785336"",""longitude"":""9978177""},{""code"":""MS203"",""name"":""Miguel de Santiago"",""latitude"":""785336"",""longitude"":""9978176""},{""code"":""MS204"",""name"":""Miguel de Santiago"",""latitude"":""785348"",""longitude"":""9978175""},{""code"":""MS205"",""name"":""Miguel de Santiago"",""latitude"":""785348"",""longitude"":""9978174""},{""code"":""MS206"",""name"":""Miguel de Santiago"",""latitude"":""785348"",""longitude"":""9978175""},{""code"":""MS207"",""name"":""Miguel de Santiago"",""latitude"":""785348"",""longitude"":""9978174""},{""code"":""MS208"",""name"":""Miguel de Santiago"",""latitude"":""785359"",""longitude"":""9978174""},{""code"":""MS209"",""name"":""Miguel de Santiago"",""latitude"":""785359"",""longitude"":""9978177""},{""code"":""MS210"",""name"":""Miguel de Santiago"",""latitude"":""785359"",""longitude"":""9978178""},{""code"":""MS211"",""name"":""Miguel de Santiago"",""latitude"":""785359"",""longitude"":""9978179""},{""code"":""MS302"",""name"":""Miguel de Santiago"",""latitude"":""785336"",""longitude"":""9978176""},{""code"":""MS303"",""name"":""Miguel de Santiago"",""latitude"":""785336"",""longitude"":""9978174""},{""code"":""MS304"",""name"":""Miguel de Santiago"",""latitude"":""785348"",""longitude"":""9978173""},{""code"":""MS305"",""name"":""Miguel de Santiago"",""latitude"":""785359"",""longitude"":""9978175""},{""code"":""MS306"",""name"":""Miguel de Santiago"",""latitude"":""785359"",""longitude"":""9978176""},{""code"":""MS307"",""name"":""Miguel de Santiago"",""latitude"":""785359"",""longitude"":""9978178""},{""code"":""N107"",""name"":""Newton"",""latitude"":""785492"",""longitude"":""9978247""}]}";
		}
	
	

	void OnGUI () {
		
		// Make a background box
		GUI.Box(new Rect(5,5,470,60), "USFQ - Map");
		s = GUI.TextField(new Rect(10, 30, 400, 20), s);

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(410,10,50,50), "Buscar")) {
			searchUSFQ(s);
			/*float h = 785593 - 785458;
			float scaleH = 50.0f / 375.0f;
			float v = 9978403 - 9978331;
			float scaleV = 50.0f / 350.0f;
			
			float posX = (-25 + (h * scaleH));
			float posZ = (-25 + (v * scaleV));
			//Debug.Log("ENTRO" + (h * scaleH));
			
			Vector3 newPos = new Vector3(posX, 0, posZ);
			
			this.transform.position = newPos;*/
			//transform.position.z = v * scaleV;
			//Application.LoadLevel(1);
		}

	}
	
	private void searchUSFQ(string q)
    {
		H = 0.0f;
		V = 0.0f;
    	GetVal("code", q);
		
       	if(H > 0.0f && V > 0.0f){
				
				float h = 785593 - H;
				float scaleH = 50.0f / 350.0f;
				float v = 9978403 - V;
				float scaleV = 50.0f / 375.0f;
				
				float posX = (-25 + (h * scaleH));
				float posZ = (-25 + (v * scaleV));
				//Debug.Log("ENTRO" + (h * scaleH));
				
				newPos = new Vector3(posX, 1, posZ);
				
				this.transform.localPosition = newPos;
				
				
				Debug.Log("H: " + H);
				Debug.Log("V: " + V);
			
				//currentCamera.transform.LookAt(this.transform);
			
			
		}
		
		
		//Debug.Log ("VAL = " + );
		
	}
	
	void Update(){
		Vector3 end = new Vector3(-newPos.x+5, -5, -newPos.z);
		
		float dist = Math.Abs(Vector3.Distance(this.transform.parent.transform.position, end));
		
		if(newPos != Vector3.zero && dist > 0.5f){
			 this.transform.parent.transform.position = Vector3.Lerp(this.transform.parent.transform.position, end, Time.deltaTime * 2);
			 this.transform.parent.transform.localScale = Vector3.Lerp(this.transform.parent.transform.localScale, new Vector3(2, 2, 2), Time.deltaTime * 2);
		}else{
			newPos = Vector3.zero;
		}
	}
	
	
	private string GetVal (string property, string v){
	
	    JsonReader reader = new JsonReader(json);
	
	    while (reader.Read()) {
			string val = "";
			if(reader.Value != null)
                val = reader.Value.ToString ();
	    	if (reader.Token.ToString() == "PropertyName" && val == property ){
				
					reader.Read();
					val = "";
					if(reader.Value != null){
                		val = reader.Value.ToString ();
					}
					
					if (val == v){
						reader.Read();
						reader.Read();
						reader.Read();
						reader.Read();
						H = float.Parse(reader.Value.ToString());
						reader.Read();
						reader.Read();
						V = float.Parse(reader.Value.ToString() );
						//Debug.Log("val=" + reader.Value.ToString());
						//return reader.Value.ToString();
					}
				
	
	     	}
			
			//Debug.Log(val);
		}
		
		return "";
	}	
	
	/*function GetVal (jsonString:String,property:String):String

{

    var reader : JsonReader = new JsonReader(jsonString);

    while (reader.Read()) 

    {

    

     if (reader.Token.ToString() == "PropertyName" && reader.Value.ToString() == property )

     {

        reader.Read();

        if (reader.Token.ToString() == "Double" || reader.Token.ToString() == "Int" || reader.Token.ToString() == "String")

            return reader.Value.ToString();

     }

    }

 

}*/


	private String[] GetArray(string jsonString, string property){
	
	    string[] array = new string[0];
		int i=0;
	
	
	    JsonReader reader = new JsonReader(jsonString);
	
	    while (reader.Read()) 
	
	    {
	
	     
	
	     if (reader.Token.ToString() == "PropertyName" && reader.Value.ToString() == property )
	
	     {
	
	        reader.Read();
	
	        if (reader.Token.ToString() == "ArrayStart")
	
	        {
	
	            while (reader.Token.ToString() != "ArrayEnd")
	
	            {
	
	                reader.Read();
	
	                if (reader.Token.ToString() == "Double" || reader.Token.ToString() == "Int" || reader.Token.ToString() == "String")
	
	                {
	
	                    array[i++] = reader.Value.ToString();
	
	                }
	
	            }
	
	        }
	
	        return array;
	
	     }
	
	    }
		
		return array;
	
	}
}
