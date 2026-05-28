import clsx from 'clsx';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import Layout from '@theme/Layout';
import HomepageFeatures from '@site/src/components/HomepageFeatures';

import Heading from '@theme/Heading';
import styles from './index.module.css';

function HomepageHeader() {
  const {siteConfig} = useDocusaurusContext();
  return (
    <header className={clsx('hero hero--light menmen-hero', styles.heroBanner)}>
      <div className="container">
        <img
          src="/img/menmen-logo.png"
          alt="闷闷的黄金屋"
          style={{ width: '330px', height: '330px', borderRadius: '50%', margin: '0 auto' }}
        />
        <Heading as="h1" className="hero__title">
          {siteConfig.title}
        </Heading>
        <p className="hero__subtitle">{siteConfig.tagline}</p>
        <div className={styles.buttons}>
          <Link
            className="button button--primary button--lg"
            to="/docs/intro">
            进入黄金屋 ✨
          </Link>
        </div>
      </div>
    </header>
  );
}

export default function Home() {
  const {siteConfig} = useDocusaurusContext();
  return (
    <Layout
      // title={`Hello from ${siteConfig.title}`}
      // description="Description will go into a meta tag in <head />">
      title = {siteConfig.title}
      description="闷闷的黄金屋"
      >
       <HomepageHeader />
       <main>
         <HomepageFeatures />
       </main>
    </Layout>
  );
}
