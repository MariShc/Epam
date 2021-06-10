const gaps = ["?", "!", ":", ";" ,",", ".", " ", "\t", "\r"];
let blacklist = {};
sort("У попа была собака");

function sort(string){ 
	for(let i=0;i<string.length;i++){ 
		let n = 0;
		for(let j = 0;j<gaps.length;j++){
			if(string[i]=gaps[j]){
				n=i;
			}
		}
		string.slice(0,n) + string.slice(n+1);
	}
	myArraySplits = string.split(" ");
	for(let i=0;i<myArraySplits.length;i++){unique(myArraySplits[i]);}
	for(let i=0;i<myArraySplits.length;i++){
		let res = "";
		for(let j=0; j<myArraySplits[i].length; j++){
			if(blacklist[myArraySplits[i][j]]==undefined){
				res+=myArraySplits[i][j];
			}
		}
		myArraySplits[i]=res;
	}
	let result = myArraySplits.join(" ");
	document.querySelector('#output').innerHTML = result;
	
	console.log(result);
}

function unique(arr) {
	let arr2 = arr;
	for(let i =0;i<arr.length;i++){
		let reiteration = 0
		const element = arr[i]
		for(let j=0;j<arr2.length;j++){
			if(arr2[j]==element){
				reiteration++;
			}
		}
		if(reiteration>=2){
			blacklist[element]=element;
		}
	}
}
