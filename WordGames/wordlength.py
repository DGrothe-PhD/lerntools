#!/usr/bin/python

'''
Calculate a word's length.
wordabbr("internationalization")
'i18n'
wordabbr("Das Pferd frisst keinen Gurkensalat")
'D1s P3d f4t k4n G9t'
'''

class WordGames:
	def __init__(self):
		self.username = input("Wie heißt du? ")
		self.points = 0
		self.maxpoints = 0
		print(f"Hallo {self.username}, viel Spaß beim Quizzen!")
	
	def wordlength(self, tx):
		if len(tx)<1:
			return 0
		'''Returns the sum of letters of a string.'''
		b = tx.split()
		j=0
		for w in b:
			j+= len(w)
		return j
		
	def wordabbrv(self, tx):
		'''Abbreviates words to w3s'''
		b = tx.split()
		r = ""
		for q in b:
			w = q.strip(".,;:!?\"()-")
			abbreviation = w[0]+str(len(w)-2)+w[-1]
			r += q.replace(w, abbreviation)
			r += " "
		print(r.rstrip())
		return r.rstrip()
	
	def GWLEngine(self):
		sample = input("Gib einen Text ein! ")
		guess = input("Wie viele Buchstaben hat der Text? ")
		try:
			if int(guess) == self.wordlength(sample):
				self.points+=1
				print(f"Richtig!")
			else:
				print(f"Irrtum.")
			self.maxpoints +=1
			self.score = int(self.points/self.maxpoints*100)
			print(f"Aktueller Stand: {self.points} von {self.maxpoints} ({self.score} %).")
		except:
			print("Eingabefehler. Möglich, dass {guess} keine Zahl ist.")
	
	def GuessWordLength(self, num_of_rounds):
		while self.maxpoints < num_of_rounds:
			self.GWLEngine()