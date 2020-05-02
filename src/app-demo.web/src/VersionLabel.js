import React from 'react';
import axios from 'axios';

export class VersionLabel extends React.Component {
    constructor() {
        super();
        this.state = {};
    }
    render() {
        return <pre>
            URL: {this.state.url}
            <br />
                data: {this.state.data}
        </pre>;
    }
    componentDidMount() {
        axios.get('https://jsonplaceholder.typicode.com/todos/1').then(res => {
            this.setState({ data: JSON.stringify(res.data) });
            this.setState({ url: res.config.url });
        }, error => console.log(error));
    }
}

export default VersionLabel;