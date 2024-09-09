import Link from 'next/link';
import A from "../components/A"
import styles from '../styles/Menu.module.css'

const Index = () => {
    return (
        <>
            <div className={styles.navbar}>
                <A href={'/'} text="Main"></A>
                <A href={'/products'} text="Shop"></A>
            </div>
            <div>
                <h1 className={styles.h1}>Main page</h1>
            </div>
        </>
    )
}

export default Index;