import { Component } from "react";
import axios from "axios";
class App extends Component {
  state = {
    message: "",
  };
  componentDidMount() {
    axios
      .get("http://localhost:5001/home/ping")
      .then((reponse) => this.setState({ message: reponse.data.message }))
      .catch(error=>{console.log(error)});
  }
  render() {
    return (
      <div className="App">
        <h1>{this.state.message}</h1>
        <h2>complete</h2>
      </div> 
    );
  }
}
export default App;
// class App extends Component{
//   constructor(props){
//     super(props);
//     this.state ={
//       items :[],
//       isloader: false,
//     }
//   }
//   componentDidMount(){
//     fetch('https://jsonplaceholder.typicode.com/users')
//     .then(res =>res.json())
//     .then(json =>{
//       this.setState({
//         isloader: true,
//         items: json,
//       })
//     });
//   }
//   render(){
//     var {items} = this.state;
//     return(
//       <div className="App">
//        <ul>
//          { items.map(item=>(
//             <li key={item.id}>
//               Name : {item.name}| Email:{item.email} 
//             </li>
//          ))};
//        </ul>
//       </div>
//     );
//   }
// }
// export default App;
