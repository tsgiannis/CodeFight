string reverseParentheses(string s) {
Stack parStack = new Stack();
			
			bool firstOpeningParentheseFound=false;
			int firstOpeningParenthese = 0;
			var arr = s.ToCharArray();
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < arr.Length; i++) {
				if (arr[i] != '(' && arr[i] != ')'){
					result.Append(arr[i]);
					}
				else {
					for (;;) {
						if (arr[i] == '('){
							parStack.Push(arr[i]);
							if(firstOpeningParentheseFound ==false){
								firstOpeningParenthese=i;
								firstOpeningParentheseFound = true;
							}
						}
						else if (arr[i] == ')' & parStack.Count>0)
							parStack.Pop();
						
						if (parStack.Count == 0){
							result.Append( reverseParentheses(Reverse(s.Substring(firstOpeningParenthese+1, i-(firstOpeningParenthese+1)))));
							firstOpeningParentheseFound = false;
							break;
						}
						i++;
					}
				
				}
			}
			string finalString = result.ToString();
			return finalString;
		}
		
 string Reverse(string s)
		{
			string output = "";
			for (int i = s.Length - 1; i >= 0; i--) {
				if (s[i] == '('){
					output += ')';
					continue;}
				if (s[i] == ')'){
					output += '(';
					continue;}
				output += s[i];
    
			}
			return output;
		}

