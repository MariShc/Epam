let buttonHandler2 = document.querySelector('#handler2');
buttonHandler2.onclick = function (event) {
   event.preventDefault();
   let str2 = document.querySelector('#inputText2');
   let res2 = document.querySelector('#outputResult2');

   function CALCULATOR(str3) {

      var chars = str3.split("");
      var n = [], op = [], index = 0, oplast = true;

      n[index] = "";

      for (var c = 0; c < chars.length; c++) {

         if (isNaN(parseInt(chars[c])) && chars[c] !== "." && !oplast) {
            op[index] = chars[c];
            index++;
            n[index] = "";
            oplast = true;
         } else {
            n[index] += chars[c];
            oplast = false;
         }
      }

      str = parseFloat(n[0]);
      for (var o = 0; o < op.length; o++) {
         var num = parseFloat(n[o + 1]);
         switch (op[o]) {
            case "+":
               str = str + num;
               break;
            case "-":
               str = str - num;
               break;
            case "*":
               str = str * num;
               break;
            case "/":
               str = str / num;
               break;
         }
      }

      return str;
   }

   res2.value = CALCULATOR(str2.value).toFixed(2);
}