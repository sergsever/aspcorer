import React from 'react';
import logo from './logo.svg';
import {HubConnection, HubConnectionBuilder } from '@microsoft/signalr'
//import './App.css';

class Signal extends React.Component
{
  constructor(props: any)
  {
    console.log('signal constructor');
    super(props);
  }
  componentDidMount()
  {
    console.log('create connection');
    const connection = new HubConnectionBuilder().withUrl('/datahub').build();
    connection.start().then(()=> console.log('hub connection:' + connection.state)).catch(err => console.log(err));
    console.log('connection state: ' + connection.state);
  }
  render()
  {
    console.log('react render');
    return <div><h1>Signal</h1><h3>HubConnect</h3></div>;
  }
}

export default Signal;
