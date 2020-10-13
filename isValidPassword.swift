import Foundation


class PasswordValidator {
    func isValidPassword(password:String) -> String {
        let passwordRegx = "(?=.*[0-9].*[0-9])(?=.*[!@#$&*%].*[!@#$&*%]).{7,}"
        let passwordCheck = NSPredicate(format: "SELF MATCHES %@",passwordRegx)
        return passwordCheck.evaluate(with: password) ? "Strong" : "Weak"
        
    }
}


