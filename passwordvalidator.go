package main

import (
    "fmt"
    "strings"
	)

func main() {
    fmt.Println("Enter Your Password: ")
    var password string
    fmt.Scan(&password)
    var chars = []string{"!", "@", "#", "$", "%", "&", "*"}
    var numbers = []string{"0","1","2","3","4","5","6","7","8","9"}
    var l = len(password)
    var specialCount=0
    var numCount=0
    
    for i:=0;i<len(chars);i++{
        if strings.Contains(password,chars[i]){
            specialCount++;
        }
        if strings.Contains(password,numbers[i]){
            numCount++;
        }   
        }
        if specialCount>=2 && numCount>=2 && l>=7{
            fmt.Println("Strong")
        }else{
            fmt.Println("Weak")
        }
    }
