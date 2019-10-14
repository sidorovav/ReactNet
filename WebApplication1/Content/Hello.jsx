class Hello extends React.Component {
    render() {
        return (<h2> Пациент {this.props.name}</h2>);
        
    }
}

class BlogPostExcerpt extends React.Component {
    render() {
        return (
            <div>
                <h1>Title</h1>
                <p>Description</p>
            </div>
        )
    }
}