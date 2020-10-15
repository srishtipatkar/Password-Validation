
function CheckPassword(pass) 
	{ 	
		var input=  /(?=.*\d{2})(?=.*[a-z])(?=[!@#\$%&\*]{2})(?=.*[A-Z]).{7,}/;
		if(pass.value.match(input)) 
	{	 
	alert('The password is Strong')
	return true;
		}else{ 
	alert('The password is Weak')
	return false;
	}
	}
