const pattern = /^(?=.*\d{2})(?=.*[\w])(?=.*[\!\@\#\$\%\$\*]{2}).{7,}$/;

const checkPassword = (password) => {
  return pattern.test(password) ? 'Strong': 'Weak';
}
