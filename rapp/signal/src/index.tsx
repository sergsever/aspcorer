import React from 'react';
import ReactDOM from 'react-dom';
//import './index.css';
import Signal from './App';
import reportWebVitals from './reportWebVitals';

const container = document.getElementById('root');

console.log('react dom container:' + container);
ReactDOM.render(<Signal/>,container);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
