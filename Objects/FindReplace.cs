using System.Collections.Generic;

namespace FindReplaceGame.Objects
{
	public class FindReplace
	{
		private string _originalSentence;
		private string _replacedWord;
		private string _newWord;

		public FindReplace(string sentence, string replacedWord, string newWord)
		{
			_originalSentence = sentence;
			_replacedWord = replacedWord;
			_newWord = newWord;
		}

			public string GetOriginalSentence()
			{
				return _originalSentence;
			}

			public string GetReplacedWord()
			{
				return _replacedWord;
			}

			public string GetNewWord()
			{
				return _newWord;
			}

			public string FindAndReplace()
			{
				// string replacedWordSpace = _replacedWord + " ";
				// string newWordSpace = _newWord + " ";
				string newSentence = _originalSentence.Replace(_replacedWord, _newWord);

				return newSentence;
			}

	}
}
