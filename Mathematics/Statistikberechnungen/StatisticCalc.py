#!/usr/bin/python
from flask import Flask, render_template
from flask import request
from flask_table import Table, Col

import ast
import statistics as stats
import numpy as np
from py_markdown_table.markdown_table import markdown_table

# initialization
class QuantileTable(Table):
    Name = Col('Name')
    Average = Col('Mittelwert')
    Minimum = Col('Min')
    Quartile1 = Col('Q1')
    Median = Col('Median')
    Quartile3 = Col('Q3')
    Maximum = Col('Max')

    

# Run app
app = Flask(__name__)

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/evalQuart', methods=['GET','POST'])
def evalQuart():
    result = ''
    if request.method == 'POST':
        raw_numbers = request.form['numbers']
        numbers = list(ast.literal_eval(raw_numbers.strip("()[]{}")))
        name = request.form['name']
        result = EvaluateQuantiles(numbers, name)
    elif request.method == 'GET':
        pass
    return render_template('index.html', tableofresults = result)

# Calculus
#example_data = [43.07, 39.23, 44.76, 42.15, 39.98, 40.5, 46.08, 38.62]


def EvaluateQuantiles(data_list, name = ""):
    # Sort first
    original_data = data_list
    data_list.sort()
    sorted_data = data_list
    print("sorted .... : ", sorted_data)
    #
    # Calculate quartiles
    Q1 = np.percentile(original_data, 25)
    Median = np.percentile(original_data, 50)
    Q3 = np.percentile(original_data, 75)
    Avg = stats.mean(original_data)
    #
    # Table
    results = [
        {
            "Name": name,
            "Average" : Avg,
            "Minimum" : sorted_data[0],
            "Quartile1" : Q1,
            "Median" : Median,
            "Quartile3": Q3,
            "Maximum" : sorted_data[-1],

        }
    ]
    
    tableofresults = QuantileTable(results)
    #tableofresults = markdown_table(results).get_markdown()
    return tableofresults

# Example

#EvaluateQuantiles(example_data, "Beispiel")


if __name__ == '__main__':
    app.run()