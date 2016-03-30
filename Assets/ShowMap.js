#pragma strict
//var miniBigCam : Camera;
var miniCam : Camera;
var Health : GameObject;
var Inv : GameObject;
var Pause: GameObject;
var wood: GameObject;
var map: GameObject;
//var inventory: GameObject;

var close: GameObject;

 
function Start () {
// Enable small minimap and disable big minimap on start
miniCam.enabled = false;
close.active=false;
//miniBigCam.enabled = false;
}
 
//Open and close Minimap
function Update () {
// I have to add double "miniBigCam.enabled = !miniBigCam.enabled;" because it's false when i click start.
if (Input.GetKeyDown(KeyCode.M)) {
    //miniCam.enabled = !miniCam.enabled;
    showMap();
}}

function showMap(){
	miniCam.enabled = !miniCam.enabled;
	Health.active=!Health.active;
	Inv.active=!Inv.active;
	map.active=!map.active;
		wood.active=!wood.active;

	Pause.active=!Pause.active;
	close.active= true;
}

function CloseMap(){
close.active=false;
	miniCam.enabled = !miniCam.enabled;
	Health.active=!Health.active;
	map.active=!map.active;
	Inv.active=!Inv.active;
	wood.active=!wood.active;

	Pause.active=!Pause.active;

}